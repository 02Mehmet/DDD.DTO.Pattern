﻿using System.Collections.Generic;

namespace QLTEQ.Domain.SeedWork
{
    /// <summary>
    /// Base class for entities.
    /// </summary>
    public abstract class Entity
    {

        protected static void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}