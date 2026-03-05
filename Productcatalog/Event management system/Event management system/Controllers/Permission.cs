using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    // Create event
    // Update event
    // Delete event
    // View registrations
}
