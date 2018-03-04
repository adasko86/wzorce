using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Carriage
    {

        public Carriage()
        {

        }

        private String number;

        private String track;

        private String sidingNumber;

        private CarriageState state;

        public String getNumber()
        {
            return number;
        }

        public void setNumber(String number)
        {
            this.number = number;
        }

        public String getTrack()
        {
            return track;
        }

        public void setTrack(String track)
        {
            this.track = track;
        }

        public String getSidingNumber()
        {
            return sidingNumber;
        }

        public void setSidingNumber(String sidingNumber)
        {
            this.sidingNumber = sidingNumber;
        }

        public void setState(CarriageState state)
        {
            this.state = state;
        }

        public CarriageState getState()
        {
           return this.state;
        }
    }
    
    public class Builder
    {

        private String number;
        private String track;
        private String sidingNumber;
        private CarriageState _state;

        public Builder quickExampleCarriage()
        {
            this.track = "1";
            this.sidingNumber = "BOC-123";
            this.number = "112";
            return this;
        }

        public Builder state(CarriageState state)
        {
            this._state = state;
            return this;
        }

        public Carriage build()
        {
            Carriage carriage = new Carriage();
            carriage.setNumber(number);
            carriage.setSidingNumber(sidingNumber);
            carriage.setTrack(track);
            carriage.setState(_state);
            return carriage;
        }
    }

}
