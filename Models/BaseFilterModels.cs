﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 基础
    /// </summary>
    public class BaseFilterModels: BaseFilterModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
    }
}
