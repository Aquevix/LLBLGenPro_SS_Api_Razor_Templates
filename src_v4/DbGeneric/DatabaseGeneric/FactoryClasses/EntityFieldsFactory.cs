﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: Friday, May 10, 2013 1:17:00 AM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using Northwind.Data;
using Northwind.Data.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Data.FactoryClasses
{
	/// <summary>Generates IEntityFields2 instances for different kind of Entities.</summary>
	public static partial class EntityFieldsFactory
	{
		private static readonly Dictionary<Northwind.Data.EntityType, string> _entityTypeNamesCache = new Dictionary<Northwind.Data.EntityType, string>();

		/// <summary>static ctor which initializes the static entity type cache.</summary>
		static EntityFieldsFactory()
		{
			foreach(Northwind.Data.EntityType value in Enum.GetValues(typeof(Northwind.Data.EntityType)))
			{
				_entityTypeNamesCache.Add(value, Enum.GetName(typeof(Northwind.Data.EntityType), value));
			}
		}	

		/// <summary>General factory entrance method which will return an EntityFields2 object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields2 CreateEntityFieldsObject(Northwind.Data.EntityType relatedEntityType)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFields(InheritanceInfoProviderSingleton.GetInstance(), _entityTypeNamesCache[relatedEntityType]);
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFieldsArray(entityName);
		}

		/// <summary>General factory entrance method which will return a TypedView EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedTypedViewType">The type of typed view the fields are for</param>
		/// <returns>The IEntityFields2 instance requested</returns>
		public static IEntityFields2 CreateTypedViewEntityFieldsObject(TypedViewType relatedTypedViewType)
		{
			IEntityFields2 fieldsToReturn=null;
			switch(relatedTypedViewType)
			{
				case TypedViewType.AlphabeticalListOfProductsTypedView:
					fieldsToReturn = CreateAlphabeticalListOfProductsTypedViewEntityFields();
					break;
				case TypedViewType.CategorySalesFor1997TypedView:
					fieldsToReturn = CreateCategorySalesFor1997TypedViewEntityFields();
					break;
				case TypedViewType.CurrentProductListTypedView:
					fieldsToReturn = CreateCurrentProductListTypedViewEntityFields();
					break;
				case TypedViewType.CustomerAndSuppliersByCityTypedView:
					fieldsToReturn = CreateCustomerAndSuppliersByCityTypedViewEntityFields();
					break;
				case TypedViewType.InvoicesTypedView:
					fieldsToReturn = CreateInvoicesTypedViewEntityFields();
					break;
				case TypedViewType.OrderDetailsExtendedTypedView:
					fieldsToReturn = CreateOrderDetailsExtendedTypedViewEntityFields();
					break;
				case TypedViewType.OrdersQryTypedView:
					fieldsToReturn = CreateOrdersQryTypedViewEntityFields();
					break;
				case TypedViewType.OrderSubtotalTypedView:
					fieldsToReturn = CreateOrderSubtotalTypedViewEntityFields();
					break;
				case TypedViewType.ProductsAboveAveragePriceTypedView:
					fieldsToReturn = CreateProductsAboveAveragePriceTypedViewEntityFields();
					break;
				case TypedViewType.ProductSalesFor1997TypedView:
					fieldsToReturn = CreateProductSalesFor1997TypedViewEntityFields();
					break;
				case TypedViewType.ProductsByCategoryTypedView:
					fieldsToReturn = CreateProductsByCategoryTypedViewEntityFields();
					break;
				case TypedViewType.QuarterlyOrderTypedView:
					fieldsToReturn = CreateQuarterlyOrderTypedViewEntityFields();
					break;
				case TypedViewType.SalesByCategoryTypedView:
					fieldsToReturn = CreateSalesByCategoryTypedViewEntityFields();
					break;
				case TypedViewType.SalesTotalsByAmountTypedView:
					fieldsToReturn = CreateSalesTotalsByAmountTypedViewEntityFields();
					break;
				case TypedViewType.SummaryOfSalesByQuarterTypedView:
					fieldsToReturn = CreateSummaryOfSalesByQuarterTypedViewEntityFields();
					break;
				case TypedViewType.SummaryOfSalesByYearTypedView:
					fieldsToReturn = CreateSummaryOfSalesByYearTypedViewEntityFields();
					break;
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the AlphabeticalListOfProductsEntity.</summary>
		private static IEntityFields2 CreateAlphabeticalListOfProductsTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)AlphabeticalListOfProductsFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("AlphabeticalListOfProductsTypedView"));
			for(int i=0;i<(int)AlphabeticalListOfProductsFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((AlphabeticalListOfProductsFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CategorySalesFor1997Entity.</summary>
		private static IEntityFields2 CreateCategorySalesFor1997TypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)CategorySalesFor1997FieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CategorySalesFor1997TypedView"));
			for(int i=0;i<(int)CategorySalesFor1997FieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CategorySalesFor1997FieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CurrentProductListEntity.</summary>
		private static IEntityFields2 CreateCurrentProductListTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)CurrentProductListFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CurrentProductListTypedView"));
			for(int i=0;i<(int)CurrentProductListFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CurrentProductListFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CustomerAndSuppliersByCityEntity.</summary>
		private static IEntityFields2 CreateCustomerAndSuppliersByCityTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)CustomerAndSuppliersByCityFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CustomerAndSuppliersByCityTypedView"));
			for(int i=0;i<(int)CustomerAndSuppliersByCityFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CustomerAndSuppliersByCityFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the InvoicesEntity.</summary>
		private static IEntityFields2 CreateInvoicesTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)InvoicesFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("InvoicesTypedView"));
			for(int i=0;i<(int)InvoicesFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((InvoicesFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrderDetailsExtendedEntity.</summary>
		private static IEntityFields2 CreateOrderDetailsExtendedTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)OrderDetailsExtendedFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrderDetailsExtendedTypedView"));
			for(int i=0;i<(int)OrderDetailsExtendedFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrderDetailsExtendedFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrdersQryEntity.</summary>
		private static IEntityFields2 CreateOrdersQryTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)OrdersQryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrdersQryTypedView"));
			for(int i=0;i<(int)OrdersQryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrdersQryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrderSubtotalEntity.</summary>
		private static IEntityFields2 CreateOrderSubtotalTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)OrderSubtotalFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrderSubtotalTypedView"));
			for(int i=0;i<(int)OrderSubtotalFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrderSubtotalFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductsAboveAveragePriceEntity.</summary>
		private static IEntityFields2 CreateProductsAboveAveragePriceTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)ProductsAboveAveragePriceFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductsAboveAveragePriceTypedView"));
			for(int i=0;i<(int)ProductsAboveAveragePriceFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductsAboveAveragePriceFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductSalesFor1997Entity.</summary>
		private static IEntityFields2 CreateProductSalesFor1997TypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)ProductSalesFor1997FieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductSalesFor1997TypedView"));
			for(int i=0;i<(int)ProductSalesFor1997FieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductSalesFor1997FieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductsByCategoryEntity.</summary>
		private static IEntityFields2 CreateProductsByCategoryTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)ProductsByCategoryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductsByCategoryTypedView"));
			for(int i=0;i<(int)ProductsByCategoryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductsByCategoryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the QuarterlyOrderEntity.</summary>
		private static IEntityFields2 CreateQuarterlyOrderTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)QuarterlyOrderFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("QuarterlyOrderTypedView"));
			for(int i=0;i<(int)QuarterlyOrderFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((QuarterlyOrderFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SalesByCategoryEntity.</summary>
		private static IEntityFields2 CreateSalesByCategoryTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)SalesByCategoryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SalesByCategoryTypedView"));
			for(int i=0;i<(int)SalesByCategoryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SalesByCategoryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SalesTotalsByAmountEntity.</summary>
		private static IEntityFields2 CreateSalesTotalsByAmountTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)SalesTotalsByAmountFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SalesTotalsByAmountTypedView"));
			for(int i=0;i<(int)SalesTotalsByAmountFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SalesTotalsByAmountFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SummaryOfSalesByQuarterEntity.</summary>
		private static IEntityFields2 CreateSummaryOfSalesByQuarterTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)SummaryOfSalesByQuarterFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SummaryOfSalesByQuarterTypedView"));
			for(int i=0;i<(int)SummaryOfSalesByQuarterFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SummaryOfSalesByQuarterFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SummaryOfSalesByYearEntity.</summary>
		private static IEntityFields2 CreateSummaryOfSalesByYearTypedViewEntityFields()
		{
			IEntityFields2 fieldsToReturn = new EntityFields2((int)SummaryOfSalesByYearFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SummaryOfSalesByYearTypedView"));
			for(int i=0;i<(int)SummaryOfSalesByYearFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SummaryOfSalesByYearFieldIndex)i);
			}
			return fieldsToReturn;
		}

		#region Included Code

        /// <summary>General factory entrance method which will return a TypedList EntityFields object with the format generated by the factory specified</summary>
        /// <param name="relatedTypedListType">The type of typed list the fields are for</param>
        /// <returns>The IEntityFields2 instance requested</returns>
        public static IEntityFields2 CreateTypedListEntityFieldsObject(TypedListType relatedTypedListType)
        {
            IEntityFields2 fieldsToReturn=null;
            switch(relatedTypedListType)
            {
                case TypedListType.EmployeesByRegionAndTerritoryTypedList:
                    fieldsToReturn = (new TypedListClasses.EmployeesByRegionAndTerritoryTypedList()).GetFieldsInfo();
                    break;
            }
            return fieldsToReturn;
        }
		#endregion
	}
}
