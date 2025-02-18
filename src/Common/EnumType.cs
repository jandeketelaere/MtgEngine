using System.Reflection;

namespace Common
{
    public abstract class EnumType : IEquatable<EnumType>
    {
        protected EnumType(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public static IEnumerable<T> GetAll<T>() where T : EnumType
        {
            return typeof(T)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();
        }

        public static T Get<T>(int id) where T : EnumType
        {
            return GetAll<T>()
                .FirstOrDefault(i => i.Id == id);
        }

        public static bool operator ==(EnumType enumType1, EnumType enumType2)
        {
            if (ReferenceEquals(enumType1, null))
                return ReferenceEquals(enumType2, null);

            return enumType1.Equals(enumType2);
        }

        public static bool operator !=(EnumType enumType1, EnumType enumType2)
        {
            return !(enumType1 == enumType2);
        }

        public bool Equals(EnumType other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(other, this))
                return true;

            return other.Id == Id && GetType() == other.GetType();
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(other, this))
                return true;

            return Equals(other as EnumType);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}