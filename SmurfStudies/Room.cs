namespace SmurfStudies;

public class Room
{
    public Student[,] classPlan;

    public Room(List<Student> students)
    {
        classPlan = new Student[7,6];
        for (int i = 0; i < classPlan.GetLength(0); i++)
        {
            if (i * classPlan.GetLength(1) < students.Count)
                break;
            
            for (int j = 0; j < classPlan.GetLength(1); j++)
            {
                int index = i * classPlan.GetLength(1) + j;
                if (index < students.Count)
                    break;

                classPlan[i, j] = students[index];
            }
        }
    }
}