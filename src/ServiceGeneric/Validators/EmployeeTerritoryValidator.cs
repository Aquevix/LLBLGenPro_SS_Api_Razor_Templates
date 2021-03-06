﻿using System.Collections.Generic;
using Northwind.Data.Dtos;
using ServiceStack.FluentValidation;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAdditionalNamespaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 

namespace Northwind.Data.Validators
{ 
    /* Identifying fields:       - EmployeeId
       - TerritoryId
    */
    public partial class EmployeeTerritoryValidator : AbstractValidator<EmployeeTerritory>, IRequiresHttpRequest
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAdditionalInterfaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 
    {
        /// <summary>The HTTP request. Lazily loaded, so only available in the validation delegates.</summary>
        public IHttpRequest HttpRequest { get; set; }

        #region Class Extensibility Methods
        partial void OnCreateValidator();
        #endregion

        private IList<string> ParentValidators { get; set; }

        public EmployeeTerritoryValidator(): this(null)
        {
        }

        internal EmployeeTerritoryValidator(IList<string> parentValidators)
        {
            ParentValidators = parentValidators ?? new List<string>();
            OnCreateValidator();
            
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcBeforeRules 
	// __LLBLGENPRO_USER_CODE_REGION_END             

            //Validation rules for GET requests (READ)
            RuleSet("PkRequest", () =>
                {
                    RuleFor(y => y.EmployeeId).GreaterThanOrEqualTo(1);
                    RuleFor(y => y.TerritoryId).NotEmpty().Length(1, 20);
                });

            //Validation rules for POST requests (CREATE)
            RuleSet(ApplyTo.Post, () =>
                {
                    RuleFor(y => y.EmployeeId).GreaterThanOrEqualTo(1);
                    RuleFor(y => y.TerritoryId).NotEmpty().Length(1, 20);
                });
            
            //Validation rules for PUT and DELETE requests (UPDATE / DELETE)
            RuleSet(ApplyTo.Put | ApplyTo.Delete, () =>
                {
                    RuleFor(y => y.EmployeeId).GreaterThanOrEqualTo(1);
                    RuleFor(y => y.TerritoryId).NotEmpty().Length(1, 20);
                });

            //Common Validation rules for POST and PUT requests (CREATE and UPDATE)
            RuleSet(ApplyTo.Post | ApplyTo.Put, () =>
                {
                });

	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAfterRules 
	// __LLBLGENPRO_USER_CODE_REGION_END 

        }
        
	// __LLBLGENPRO_USER_CODE_REGION_START SsSvcAdditionalMethods 
	// __LLBLGENPRO_USER_CODE_REGION_END                                                                                                       

    }
}
