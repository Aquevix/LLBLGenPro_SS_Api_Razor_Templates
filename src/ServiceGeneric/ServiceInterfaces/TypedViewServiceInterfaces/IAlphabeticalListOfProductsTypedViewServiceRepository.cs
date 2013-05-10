﻿using Northwind.Data.Dtos;
using Northwind.Data.Dtos.TypedViewDtos;
using Northwind.Data.Services.TypedViewServices;
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAdditionalNamespaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 

namespace Northwind.Data.ServiceInterfaces.TypedViewServiceInterfaces
{ 
    public interface IAlphabeticalListOfProductsTypedViewServiceRepository: ITypedViewServiceRepository<AlphabeticalListOfProducts>
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAdditionalInterfaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 
    {
        TypedViewMetaDetailsResponse GetTypedViewMetaDetails(ServiceStack.ServiceInterface.Service service);
        DataTableResponse GetDataTableResponse(AlphabeticalListOfProductsDataTableRequest request);
        AlphabeticalListOfProductsCollectionResponse Fetch(AlphabeticalListOfProductsQueryCollectionRequest request);
        
	// __LLBLGENPRO_USER_CODE_REGION_START SsTypedViewSvcAdditionalMethods 
	// __LLBLGENPRO_USER_CODE_REGION_END 

    } 
}
