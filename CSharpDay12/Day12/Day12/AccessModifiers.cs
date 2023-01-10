namespace Day12
{
    internal class AccessModifiers
    {
        #region fields
        private int _id;
        private string _name;
        private string _email;

        #endregion

        #region properties
        public int Salary { get; set; }
        public double Tax { get; set; }
        #endregion

        #region Constructors
        public AccessModifiers(int id, string name, string email)
        {

        }
        public AccessModifiers()
        {
            Tax = 0.10D;
        }
        #endregion
    }
}
