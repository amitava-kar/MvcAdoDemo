using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace MVCAdoDemo.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = @"Data Source=C:/SQLiteStudio/LAPTOP-5ESUGQC3.db;Pooling=true"; 

        //SQLite3 connection
           
            public IEnumerable<Employee> GetAllEmployees() {              
                    List<Employee> lstemployee = new List<Employee>();                    
                    using (SQLiteConnection con = new SQLiteConnection(connectionString)) {
                            con.Open();
                            SQLiteCommand cmd = new SQLiteCommand(con);
                            //cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * FROM Employees_old";
                            SQLiteDataReader rdr = cmd.ExecuteReader(); 
                            while (rdr.Read()) {
                                    Employee employee = new Employee();
                                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                                    employee.Name = rdr["Name"].ToString(); 
                                    employee.Address = rdr["Address"].ToString(); 
                                    employee.Designation = rdr["Designation"].ToString(); 
                                    employee.Salary = (decimal) rdr["Salary"];
                                    employee.JoiningDate = (DateTime) rdr["JoiningDate"]; 
                                    lstemployee.Add(employee); 
                                }
                                con.Close(); 
                            }                
                            return lstemployee;            
            }                
                    
            //To Add new employee record              
            public void AddEmployee(Employee employee) {                
                using (SQLiteConnection con = new SQLiteConnection(connectionString)) {                    
                    //SQLiteCommand cmd = new SQLiteCommand("spAddEmployee", con);                    
                    //cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO Employees_old (Name, Address, Designation, Salary, JoiningDate) VALUES(@Name, @Address, @Designation, @Salary, @JoiningDate)";
                       
                    cmd.Parameters.AddWithValue("@Name", employee.Name);                    
                    cmd.Parameters.AddWithValue("@Address", employee.Address);                    
                    cmd.Parameters.AddWithValue("@Designation", employee.Designation);                    
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);                        
                    
                    cmd.ExecuteNonQuery();                    
                    con.Close();                
                }            
            }                
                    
                    //To Update the records of a particluar employee            
                    public void UpdateEmployee(Employee employee) {
                        using (SQLiteConnection con = new SQLiteConnection(connectionString)) {
                            /*
                            SQLiteCommand cmd = new SQLiteCommand("spUpdateEmployee", con);                    
                            cmd.CommandType = CommandType.StoredProcedure; 
                            */ 
                            con.Open();
                            SQLiteCommand cmd = new SQLiteCommand(con);
                            //cmd.CommandType = CommandType.Text;

                            //SQLiteDataReader rdr = cmd.ExecuteReader();
                            cmd.CommandText = "UPDATE Employees_old SET Name = @Name, Address = @Address, Designation = @Designation, Salary = @Salary, JoiningDate = @JoiningDate WHERE EmployeeId = @EmployeeId";

                            cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);                    
                            cmd.Parameters.AddWithValue("@Name", employee.Name);                    
                            cmd.Parameters.AddWithValue("@Address", employee.Address);                    
                            cmd.Parameters.AddWithValue("@Designation", employee.Designation);                    
                            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                            cmd.Parameters.AddWithValue("@JoiningDate", employee.JoiningDate);

                            cmd.ExecuteNonQuery();                    
                            con.Close();                
                        }            
                    }                
                    
                    //Get the details of a particular employee            
                    public Employee GetEmployeeData(int? id) {                
                        Employee employee = new Employee();                    
                        using (SQLiteConnection con = new SQLiteConnection(connectionString)) { 
                            /*                   
                            string sqlQuery = "SELECT * FROM tblEmployee WHERE EmployeeID= " + id;                    
                            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, con);                        
                            con.Open();                    
                            SQLiteDataReader rdr = cmd.ExecuteReader();
                            */
                            con.Open();
                            SQLiteCommand cmd = new SQLiteCommand(con);
                            //cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT * FROM Employees_old WHERE EmployeeID= " + id;
                            SQLiteDataReader rdr = cmd.ExecuteReader();

                            while (rdr.Read()) {                        
                                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                                    employee.Name = rdr["Name"].ToString(); 
                                    employee.Address = rdr["Address"].ToString(); 
                                    employee.Designation = rdr["Designation"].ToString(); 
                                    employee.Salary = (decimal) rdr["Salary"];
                                    employee.JoiningDate = (DateTime) rdr["JoiningDate"];                    
                            }
                            con.Close();                
                        }                
                        return employee;            
                    }                
                    
                    //To Delete the record on a particular employee            
                    public void DeleteEmployee(int? id) {  
                        Employee employee = new Employee();                  
                        using (SQLiteConnection con = new SQLiteConnection(connectionString)) {                   
                            /*
                            SQLiteCommand cmd = new SQLiteCommand("spDeleteEmployee", con);                    
                            cmd.CommandType = CommandType.StoredProcedure; 
                            */ 
                            con.Open();
                            SQLiteCommand cmd = new SQLiteCommand(con);
                            //cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "DELETE FROM Employees_old WHERE EmployeeID = @EmployeeId";
                            //SQLiteDataReader rdr = cmd.ExecuteReader();

                            cmd.Parameters.AddWithValue("@EmployeeId", id);                        
                    
                            cmd.ExecuteNonQuery();                    
                            con.Close();                
                        }            
                    }        
                    
                }    
                
            }
