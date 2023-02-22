using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace WebEnterpriseProject.Models;

{
	public class User : IdentityUser
		{
			[Key]
		    public int Id { get; set; }
    		public RoleStatus RoleId { get; set; } = RoleStatus.RoleId;
		    public int DepartmentId {get; set;}
			public Department Department { get; set; }
		    public string UserName { get; set; }
		    public string UserEmail { get; set; }
		    public string UserPassword { get; set; }
		}
}