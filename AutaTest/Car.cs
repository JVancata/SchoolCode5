using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutaTest
{
    class Car
    {
        private string color;
        private int mileage;
        private string dateMade;
        private bool isMoving;

        public Car (string color, int mileage, string dateMade, bool isMoving)
        {
            this.color = color;
            this.mileage = mileage;
            this.dateMade = dateMade;
            this.isMoving = isMoving;
        }
        //přístupová rozhraní
        #region
        public string Color
        {
            get {
                return this.color;
            }
            set {
                this.color = value;
            }
        }

        public int Mileage
        {
            get
            {
                return this.mileage;
            }
            set
            {
                this.mileage = value;
            }
        }

        public string DateMade
        {
            get
            {
                return this.dateMade;
            }
            set
            {
                this.dateMade = value;
            }
        }

        public bool IsMoving
        {
            get
            {
                return this.isMoving;
            }
            set
            {
                this.isMoving = value;
            }
        }
        #endregion
        public override string ToString()
        {
            string moving;
            if (this.isMoving)
            {
                moving = "hýbe";
            }
            else
            {
                moving = "nehýbe";
            }
            return "Vypisuješ class Auto. Toto konkrétní auto má barvu " + this.color + ". Má najeto " + this.mileage + " kilometrů a právě se "+moving+". Bylo vyrobeno v roce " + this.dateMade;
        }
    }
}
