using System;
namespace GlobalX
{
    // Entity Class Person with two instance variable _fName and _lName
    public class Person{

		//instance Variable
		string _fName;
        string _lName;

        //default constructor
        public Person(){
            _fName = "";
            _lName = "";
        }

        public Person(string record)
		{
            string[] names = record.Split(',');
            _fName = names[0];
            _lName = names[1];
		}

        //constructor wiith parameters fName and lName
		public Person(string fName, string lName){
            _fName = fName;
			_lName = lName;
		}

        // getter and setter for _fName
        public string FName{
            get{
                return _fName;
            }
            set{
                _fName = value;   
            }
        }

		// getter and setter for _lName
		public string LName{
            get{
                return _lName;
            }
			set{
                _lName = value;
			}
        }
    }
}
