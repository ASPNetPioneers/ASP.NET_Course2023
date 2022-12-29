namespace Encapsulation
{
    internal class Student
    {
        // fields members
        private int _id;
        private string _name;
        private string _email;
        private int _passMark = 100;

        // Getter and Setters
        //internal void SetID(int id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new ArgumentException("Student ID should be greater than zero.");
        //    }
        //    this._id = id;
        //}
        //internal int GetId(int id)
        //{
        //    return this._id = id;
        //}

        //internal void SetName(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        throw new ArgumentException("Student name should not be empty.");
        //    }
        //    this._name = name;
        //}
        //internal string GetName(string name)
        //{
        //    return this._name = name;
        //}

        //internal int GetPassMark()
        //{
        //    return _passMark;
        //}


        // Property members
        internal int ID
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student ID should be greater than zero.");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        internal string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student name should not be empty.");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
        internal string Email { get; set; }
        internal int PassMark
        {
            get
            {
                return _passMark;
            }
        }
        // Methods

        internal void StudentDetails()
        {
            Console.WriteLine($"\nID: {ID}\nName: {Name}\nEmail: {Email}\nMark: {PassMark}");
        }
    }
}
