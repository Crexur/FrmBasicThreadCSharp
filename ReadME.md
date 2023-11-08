FrmBasicThreadCSharp - Basic Thread Simulation in C#
This is a simple C# program that simulates the execution of two threads working together. 
The program creates two threads ThreadA and ThreadB, each executing an finite loop with a 1500 millisecond pause between iterations. 
The loops are terminated when the loop count variable reaches 5. 
The thread is terminated using the break method and a label on the Windows Form is updated with "label1.Text = "-End Of Thread"; Terminated" message once the thread has finished executing.

