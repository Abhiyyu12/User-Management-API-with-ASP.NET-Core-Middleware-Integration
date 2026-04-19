public User Add(User user)
{
    if (user == null)
        throw new ArgumentNullException(nameof(user));

    user.Id = _nextId++;
    _users.Add(user);
    return user;
}
