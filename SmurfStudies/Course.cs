namespace SmurfStudies;

public class Course
{
    public Prof Prof;
    public List<Student> Students;
    public Room Room;
    
    public Subject Subject { get; private set; }
    public int StartTime { get; private set; }
    public int Duration { get; private set; }

    public Course(Prof prof, Subject subject, Room room, int startTime, int duration)
    {
        if (!prof.preferedSubjects.Contains(subject))
            throw new ArgumentException();

        Prof = prof;
        Subject = subject;
        StartTime = startTime;
        Duration = duration;
    }
}