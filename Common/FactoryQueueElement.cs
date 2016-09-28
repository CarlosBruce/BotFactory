using Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class FactoryQueueElement : IFactoryQueueElement
    {
        private string _name;
        private Type _model;
        private Coordinates _parkingPos;
        private Coordinates _workingPos;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Type Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public Coordinates ParkingPos
        {
            get
            {
                return _parkingPos;
            }

            set
            {
                _parkingPos = value;
            }
        }

        public Coordinates WorkingPos
        {
            get
            {
                return _workingPos;
            }

            set
            {
                _workingPos = value;
            }
        }
    }
}
