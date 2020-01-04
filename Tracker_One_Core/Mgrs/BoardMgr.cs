using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_One_Core.Access;
using Tracker_One_Core.Model;

namespace Tracker_One_Core
{
    public class BoardMgr
    {
        Board _board;

        /// <summary>
        /// Init a board and fill/load the Entities list using Repository access layer to read and parse the json data.
        /// </summary>
        /// <returns></returns>
        public bool BoardInit()
        {
            _board = new Board();
            _board.Entities = Repository.GetEntitiesListFromJson();
            return true;
        }

        /// <summary>
        /// Iterates through the list of entities and for each of them relocate it at a new position.
        /// </summary>
        /// <returns></returns>
        public bool RepositionEntities()
        {
            foreach (var xe in _board.Entities)
            {
                RepositionEntity(xe);
            }
            return true;
        }

        private void RepositionEntity(XEntity xe)
        {
            int newX = -1;
            int newY = -1;

            do
            {
                var direction = HelperMethods.GetRandomDirection(xe);
                switch (direction)
                {
                    case MovementDirection.UP:
                    case MovementDirection.DOWN:
                        newY = GetValidVertical(xe.Y, direction);
                        newX = xe.X;
                        break;
                    case MovementDirection.RIGHT:
                    case MovementDirection.LEFT:
                        newX = GetValidHorisental(xe.X, direction);
                        newY = xe.Y;
                        break;
                }
            }
            // If new point equals prev point.. need to get new posision
            while (newX == xe.PrevPoint.X && newY == xe.PrevPoint.Y);

            // Save current to prev point
            xe.PrevPoint = new Point(xe.X, xe.Y);

            // reposition entity with the new point
            xe.X = newX;
            xe.Y = newY;

            // Update the history track list and remove the last extra step if the list exceeded the number of his steps the user selected
            xe.HistoryTrack.Insert(0, new Point(newX, newY));
            if (xe.HistoryTrack.Count > _board.HisNumberOfSteps)
                xe.HistoryTrack.RemoveRange(_board.HisNumberOfSteps - 1, xe.HistoryTrack.Count - _board.HisNumberOfSteps);
        }

        private int GetValidVertical(int entityY, MovementDirection direction)
        {
            // Note!! Entity Y Increas is boed decreas and vice versa.
            if (direction == MovementDirection.UP)
            {
                // On up direction validate the new position is not out of board's top.
                if ((entityY + 1) < Constants.boardSize)
                    return ++entityY;

                return entityY;
            }
            else if (direction == MovementDirection.DOWN)
            {
                // On down direction validate the new position is not out of board's bottom.
                if ((entityY - 1) > 0)
                    return --entityY;

                return entityY;
            }

            return entityY;
        }


        private int GetValidHorisental(int entityX, MovementDirection direction)
        {
            // Note!! Entity Y Increas is boed decreas and vice versa.
            if (direction == MovementDirection.RIGHT)
            {
                // On Right direction validate the new position is not out of board's right.
                if ((entityX + 1) < Constants.boardSize)
                    return ++entityX;

                return entityX;
            }
            else if (direction == MovementDirection.LEFT)
            {
                // On left direction validate the new position is not out of board's left.
                if ((entityX - 1) > 0)
                    return --entityX;

                return entityX;
            }

            return entityX;
        }


        /// <summary>
        /// Saves the data to csv file.
        /// Save history steps according to HistoryNunberOfSteps.
        /// </summary>
        /// <returns></returns>
        public bool SaveDataToCsv()
        {
            Repository.SaveEntitiesListToCsv(_board.Entities);
            return true;
        }

        /// <summary>
        /// Sets board.HisNumberOfSteps after. Validates min=1 and max = 5.
        /// </summary>
        /// <param name="numOfHisSteps"></param>
        public void SetHistoryNunberOfSteps(int numOfHisSteps)
        {
            if (numOfHisSteps > 5)
                numOfHisSteps = 5;
            if (numOfHisSteps < 1)
                numOfHisSteps = 1;

            _board.HisNumberOfSteps = numOfHisSteps;
        }

        public int GetMinHisStepsValueFromConfig()
        {
            int minSteps = 1;
            var minVal = ConfigurationManager.AppSettings["MinHisSteps"];
            if (!string.IsNullOrEmpty(minVal))
                Int32.TryParse(minVal, out  minSteps);

            return minSteps;
        }

        public int GetMaxHisStepsValueFromConfig()
        {
            int maxSteps = 5;
            var maxVal = ConfigurationManager.AppSettings["MaxHisSteps"];
            if (!string.IsNullOrEmpty(maxVal))
                Int32.TryParse(maxVal, out  maxSteps);

            return maxSteps;

        }

        /// <summary>
        /// Returns a list of diplay version of the entities.
        /// </summary>
        /// <returns></returns>
        public List<XDisplayEntity> GetEntitiesDisplayList()
        {
            // Return a new list for display. That way we can be sure the the actual list is not to be changed unintendedly.
            return _board.Entities.Select(o => new XDisplayEntity() { Id = o.entity_ID, DisplayName = o.DisplayName }).ToList();
        }


        public List<XEntity> GetEntitiesList()
        {
            return _board.Entities;
        }
    }


}
