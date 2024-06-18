using System.ComponentModel.DataAnnotations;

namespace BusinessControlDotnet.Models;

public enum EmployeeStatus
{
  Hired,
  Fired,
  Terminated
}

public class Employee 
{
  public int Id { get; set; }
  public required string FirstName { get; set; }
  public required string LastName { get; set; }
  public required string BirthDate { get; set; }
  public required string Street { get; set; }
  public required string City { get; set; }

  [RegularExpression("^[0-9]{2}-[0-9]{3}$")]
  public required string PostalCode { get; set; }

  [RegularExpression("^[0-9]{3}-{0,1}[0-9]{3}-{0,1}[0-9]{3}$")]
  public required string PhoneNumber { get; set; }
  public required EmployeeStatus Status { get; set; }
  public required string Position { get; set; }
  public required double Salary { get; set; }
  public DateTime Updated { get; set; } = DateTime.Now;
  public DateTime Created { get; set; } = DateTime.Now;

  
}