namespace SIGMA_MOTORS
{
    /// <summary>
    /// Simple static session — populate this on successful login.
    /// Usage:  SessionManager.EmployeeId   = dr["EMPLOYEE_ID"];
    ///         SessionManager.EmployeeName = dr["NAME"];
    /// </summary>
    public static class SessionManager
    {
        public static int EmployeeId { get; set; } = 0;
        public static string EmployeeName { get; set; } = "Unknown";
        public static string Role { get; set; } = "";

        public static void Clear()
        {
            EmployeeId = 0;
            EmployeeName = "Unknown";
            Role = "";
        }
    }
}