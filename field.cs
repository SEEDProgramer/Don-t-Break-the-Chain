using System;

namespace Callendar
{
	/// <summary>
	/// Description of field.
	/// </summary>
	public class field
	{
		int foregrnd;
		int backgrnd;
		int _value;
		
		public field()
		{
		}

        public int Foregrnd
        {
            get
            {
                return foregrnd;
            }

            set
            {
                foregrnd = value;
            }
        }

        public int Backgrnd
        {
            get
            {
                return backgrnd;
            }

            set
            {
                backgrnd = value;
            }
        }
    }
}
