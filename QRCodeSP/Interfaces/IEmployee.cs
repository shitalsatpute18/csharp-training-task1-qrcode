using System.Reflection.Metadata;

namespace QRCodeSP.Interfaces
{
    public interface IEmployee   // Define the IEmployee interface
    {
        //Property declaration
        string? EmployeeId { get; set; }      //Propertytype ? PropertyName { get; set; };
                                              //Here the property type is string(which hold string or null value)
        string? Technicalskills { get; set; }
        string? OrgName { get; set; }
        string? AccountName { get; set; }
    }
}



//Inteface is a contract that defines a set of methods, properties, events,indexers that a class or struct must implement
//Interface cannot be instantiated directly.
//Interfaces can be implemented by the class/struct