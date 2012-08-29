﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveDomain.Core
{
	public interface ICommandJournal
	{


        /// <summary>
        /// Creates next empty journal segment
        /// </summary>
        void CreateNextSegment();

        /// <summary>
        /// return the entire sequence of journalentries
        /// </summary>
        /// <returns></returns>
        IEnumerable<JournalEntry<Command>> GetAllEntries();


        /// <summary>
        /// Get entries from a specified position. 
        /// Used when restoring from a snapshot
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        IEnumerable<JournalEntry<Command>> GetEntriesFrom(JournalSegmentInfo position);

        /// <summary>
        /// Open for appending
        /// </summary>
		void Open();

        /// <summary>
        /// Write a command to the log
        /// </summary>
        void Append(Command command);

        /// <summary>
        /// Close for writing
        /// </summary>
		void Close();
	}
}
