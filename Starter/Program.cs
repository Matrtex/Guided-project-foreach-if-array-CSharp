// 初始化变量 - 已评分的作业
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// 学生姓名
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// 将报告头写入控制台
Console.WriteLine("Student\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // 初始化/重置已评分作业的总分
    int sumAssignmentScores = 0;

    // 初始化/重置计算出的考试+额外学分的平均分
    decimal currentStudentGrade = 0;

    // 初始化/重置作业数量的计数器
    int gradedAssignments = 0;

    // 遍历分数数组并为当前学生完成计算
    foreach (int score in studentScores)
    {
        // 增加作业计数器
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // 将考试分数加入总分
            sumAssignmentScores += score;

        else
            // 将额外学分加入总分 - 奖励分等于考试分数的10%
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t0\t\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}\t\t0 (0 pts)");
}

// 在 VS Code 中运行时所需（保持输出窗口打开以查看结果）
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
