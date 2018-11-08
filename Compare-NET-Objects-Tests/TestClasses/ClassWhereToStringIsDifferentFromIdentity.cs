namespace KellermanSoftware.CompareNetObjectsTests.TestClasses
{
    public class ClassWhereToStringIsDifferentFromIdentity
    {
        readonly string _importantValue;
        readonly string _unimportantValue;

        public ClassWhereToStringIsDifferentFromIdentity(string importantValue, string unimportantValue)
        {
            _importantValue = importantValue;
            _unimportantValue = unimportantValue;
        }

        public override string ToString()
        {
            return $"{_importantValue} - {_unimportantValue}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return _importantValue == ((ClassWhereToStringIsDifferentFromIdentity)obj)._importantValue;
        }
    }
}
