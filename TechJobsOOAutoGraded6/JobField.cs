using System;
namespace TechJobsOOAutoGraded6;

public abstract class JobField
{
    public int Id { get; }
    private static int nextId = 1;
    public string Value { get; set; }

    public JobField(string value)
    {
        Id = nextId;
        nextId++;
        Value = value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public override string ToString()
    {
        return Value;
    }
   public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        return Equals((JobField)obj);
    }

    
}