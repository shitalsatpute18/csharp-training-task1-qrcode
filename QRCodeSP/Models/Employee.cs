using QRCodeSP.Interfaces;

namespace QRCodeSP.Models   //namspace organizing code. 
{
    //Implement the IEmployee interface in the Employee class
     public class Employee : IEmployee    //public keyword is access modifier means the class is accessible from any other code in the application.
    {                                     //Employee class implements the IEmployee interface                          
                                          //Employee class must provide implementations for all members defined in the IEmployee interface.
                                          //Employee class must implement methods or properties specified in IEmployee interface

        //Property declaration-PascalCase (ex- EmployeeId) naming convention followed while declaring the property
        public string? EmployeeId { get; set; }   //public keyword makes the property accessible from outside the class.It means that other classes can get or set the value of this property.   
                                                  //EmployeeId is the name of the property,which is public means property can be accessed from outside the class
                                                  //string-nullable string type which means property hold the string or null value.
                                                  //{get ; set ;} The property has both a getter and setter(known as accessors for the property), allowing to read and modified the property(EmployeeId)
                                                  //The get accessor returns the value of the property, and the set accessor assigns a new value to the property.
        public string? Technicalskills { get; set; }  // Techincalskills,OrgName,AccountName are the names of property
        public string? OrgName { get; set; }
        public string? AccountName { get; set; }
    }
}






