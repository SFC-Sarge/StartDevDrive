using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StartDevDrive
{
    /// <summary>
    /// 
    /// </summary>
    public static class WriteAllLines
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task CreateDevelopmentTxtFileAsync()
        {
            string vhdxDriveLetter = Properties.Resources.VhdxAssignedDriveLetter;
            string[] lines  = {$"select vdisk file=\"{Properties.Resources.VhdxDriveLocation}{Properties.Resources.VhdxFileName}\"", "attach vdisk", $"assign letter={vhdxDriveLetter.First()}", "exit".TrimEnd()};

            await File.WriteAllLinesAsync($"{AppContext.BaseDirectory}Development1.txt", lines);
        }
    }
}
