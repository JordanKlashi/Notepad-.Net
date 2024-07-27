using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Objects
{
    internal class TextFile
    {
        /// <summary>
        /// Chemin d'accès et nom du fichier 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Chemin d'accès et nom du fichier Backup.
        /// </summary>
        public string BackupFileName { get; set; }

        /// <summary>
        /// Nom et exension du fichier. Le nom du fichier n'inclut pas le chemin d'accès
        /// </summary>
        public string SafeFileName { get; set; }

        /// <summary>
        /// Nom et extension du fichier backup. Le nom du fichier n'inclut pas le chemin d'accès
        /// </summary>
        public string SafeBackupFileName { get; set; }

        /// <summary>
        /// Contenu du fichier.
        /// </summary>
        public string Content { get; set; }

        public TextFile() { }

        public TextFile(string fileName)
        {
            FileName = fileName;
            SafeFileName = Path.GetFileName(fileName);
        }


    }
}
