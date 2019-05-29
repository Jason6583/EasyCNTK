﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCNTK.Learning
{
    /// <summary>
    /// Представляет результат одной сессии обучения
    /// </summary>
    public class FitResult
    {
        /// <summary>
        /// Средняя ошибка функции потерь по результатам сессии обучения
        /// </summary>
        public double LossError { get; set; }
        /// <summary>
        /// Средняя ошибка оценочной функции по результатам сессии обучения
        /// </summary>
        public double EvaluationError { get; set; }
        /// <summary>
        /// Продолжительность сессии обучения
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Количество эпох обучения
        /// </summary>
        public int EpochCount { get; set; }
        /// <summary>
        /// Кривая ошибок функции потерь в процессе обучения
        /// </summary>
        public List<double> LossCurve { get; set; }
        /// <summary>
        /// Кривая ошибок оценочной функции в процессе обучения
        /// </summary>
        public List<double> EvaluationCurve { get; set; }
    }
}
