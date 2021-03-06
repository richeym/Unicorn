﻿using System;
using Sitecore.Data.Items;
using Unicorn.Data;
using Unicorn.Serialization;

namespace Unicorn
{
	/// <summary>
	/// Provides log messages that can be responded to from the UnicornDataProvider.
	/// </summary>
	public interface IUnicornDataProviderLogger
	{
		void RenamedItem(string providerName, ISourceItem sourceItem, string oldName);

		void SavedItem(string providerName, ISourceItem sourceItem, string triggerReason);

		void MovedItemToNonIncludedLocation(string providerName, ISerializedItem existingItem);

		void MovedItem(string providerName, ISourceItem sourceItem, ISourceItem destinationItem);
		void CopiedItem(string providerName, Func<ISourceItem> sourceItem, ISourceItem copiedItem);

		void DeletedItem(string providerName, ISerializedItem existingItem);

		void SaveRejectedAsInconsequential(string providerName, ItemChanges changes);
	}
}
