namespace SmurfStudies;

public class Room
{
    public Student[,] ClassPlan;

    public Room(List<Student> students)
    {
        ClassPlan = new Student[7,6];
        for (int i = 0; i < ClassPlan.GetLength(0); i++)
        {
            if (i * ClassPlan.GetLength(1) < students.Count)
                break;
            
            for (int j = 0; j < ClassPlan.GetLength(1); j++)
            {
                int index = i * ClassPlan.GetLength(1) + j;
                if (index < students.Count)
                    break;

                ClassPlan[i, j] = students[index];
            }
        }
    }
}