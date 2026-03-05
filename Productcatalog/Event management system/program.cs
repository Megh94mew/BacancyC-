builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

{
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey =
              new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("YourSuperSecretKey"))
        };
    });

// ------------------------ Rate limitting -----------------------

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 10;
        opt.Window = TimeSpan.FromMinutes(1);
        opt.QueueLimit = 0;
    });
});

app.UseRateLimiter();
//------------------------ Dependency Injection -----------------------
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IAuthService, AuthService>();

public EventController(IEventService service)
{
    _service = service;
}
Authorization: Bearer { token}
