var claims = new[]
{
    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
    new Claim(ClaimTypes.Role, user.Role)
};

var key = new SymmetricSecurityKey(
    Encoding.UTF8.GetBytes("YourSuperSecretKey"));

var token = new JwtSecurityToken(
    claims: claims,
    expires: DateTime.UtcNow.AddMinutes(60),
    signingCredentials:
        new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
);

return new JwtSecurityTokenHandler().WriteToken(token);