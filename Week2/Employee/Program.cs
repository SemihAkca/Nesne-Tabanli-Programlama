using Hafta2_odev;

Employee employee1 = new Employee(11, "Ali", "Yılmaz");
Employee employee2 = new Employee(12, "Fırat", "Kurnaz");
Employee employee3 = new Employee(13,"Yaman","Ballı");

EmployeeManager employeeManager = new EmployeeManager();
employeeManager.Add(employee1);
employeeManager.Add(employee2);
employeeManager.Add(employee3);

employeeManager.Remove(11);
employeeManager.Remove(19);






