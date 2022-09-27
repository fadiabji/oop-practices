using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    abstract class EngineVehicle
    { 
        private int _RemainingFuel;
        private int _speed;
        
        public virtual int RemainingFuel
        {
            get { return _RemainingFuel; }
            set 
            {
                _RemainingFuel = value;
                if (_RemainingFuel < 0 ) { _RemainingFuel = 0; }
                if (_RemainingFuel > 150) { _RemainingFuel = 150; }
            }
        }
        public virtual int speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                if (_speed > 160) { _speed = 160; }
                if (_speed < 0) { _speed = 0; }
            }
        }
        public EngineVehicle() { RemainingFuel = 0; speed = 0;}
    }
}
