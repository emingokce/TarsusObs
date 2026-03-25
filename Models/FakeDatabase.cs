namespace TarsusObs.Models;

public class FakeDatabase
{
    
    private static List<Department> _departments=new List<Department>();

    public static List<Department> GetDepartments()
    {
        return _departments;
    }

    public static void AddDepartment(Department dep)
    {
        _departments.Add(dep);
    }



}