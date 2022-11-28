int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time = 0;
bool isDirectionFirstFriend = false;

while (distance > 10)
{
    
    if(isDirectionFirstFriend)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        isDirectionFirstFriend = false;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        isDirectionFirstFriend = true;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.WriteLine($"Собака пробежит {count} раз(а).");