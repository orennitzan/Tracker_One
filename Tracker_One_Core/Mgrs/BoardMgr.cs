using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker_One_Core.Access;

namespace Tracker_One_Core
{
    public class BoardMgr
    {
        Board board;

        /// <summary>
        /// Init a board and fill/load the Entities list using Repository access layer to read and parse the json data.
        /// </summary>
        /// <returns></returns>
        public bool BoardInit()
        {
            board = new Board();
            board.Entities = Repository.GetEntitiesListFromJson();
            return true;
        }
        
        /// <summary>
        /// Iterates through the list of entities and for each of them relocate it at a new position.
        /// </summary>
        /// <returns></returns>
        public bool RepositionEntities()
        {

            return false;
        }

        /// <summary>
        /// Saves the data to csv file.
        /// Save history steps according to HistoryNunberOfSteps.
        /// </summary>
        /// <returns></returns>
        public bool SaveDataToCsv()
        {
            return false;
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

            board.HisNumberOfSteps = numOfHisSteps;
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
    }
}
