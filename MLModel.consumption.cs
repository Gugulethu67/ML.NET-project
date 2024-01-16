﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Team21
{
    public partial class MLModel
    {
        /// <summary>
        /// model input class for MLModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"ProductID")]
            public float ProductID { get; set; }

            [ColumnName(@"ProductName")]
            public string ProductName { get; set; }

            [ColumnName(@"Date")]
            public string Date { get; set; }

            [ColumnName(@"StockOnHand")]
            public float StockOnHand { get; set; }

            [ColumnName(@"DeliveredQuantity")]
            public float DeliveredQuantity { get; set; }

            [ColumnName(@"SalesQuantity")]
            public float SalesQuantity { get; set; }

            [ColumnName(@"WasteQuantity")]
            public float WasteQuantity { get; set; }

            [ColumnName(@"BoughtStock")]
            public float BoughtStock { get; set; }

            [ColumnName(@"Temperature")]
            public float Temperature { get; set; }

            [ColumnName(@"Precipitation")]
            public float Precipitation { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"ProductID")]
            public float ProductID { get; set; }

            [ColumnName(@"ProductName")]
            public float[] ProductName { get; set; }

            [ColumnName(@"Date")]
            public string Date { get; set; }

            [ColumnName(@"StockOnHand")]
            public float StockOnHand { get; set; }

            [ColumnName(@"DeliveredQuantity")]
            public float DeliveredQuantity { get; set; }

            [ColumnName(@"SalesQuantity")]
            public float SalesQuantity { get; set; }

            [ColumnName(@"WasteQuantity")]
            public float WasteQuantity { get; set; }

            [ColumnName(@"BoughtStock")]
            public float BoughtStock { get; set; }

            [ColumnName(@"Temperature")]
            public float Temperature { get; set; }

            [ColumnName(@"Precipitation")]
            public float Precipitation { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
