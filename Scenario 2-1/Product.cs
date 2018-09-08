using System;

namespace Scenario_2_1
{
    class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }

                name = value;
            }
        }
    }
}
