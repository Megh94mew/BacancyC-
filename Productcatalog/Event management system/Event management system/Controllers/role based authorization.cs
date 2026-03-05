using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "Admin")]
[Authorize(Roles = "Organizer")]
[Authorize(Roles = "Attendee")]
