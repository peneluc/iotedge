﻿using System.Collections.Generic;

namespace IotEdgeModuloCentral.Tipos
{
    //{
    //    "PublishTimestamp": "2020-03-25 23:36:51",
    //    "Content": [
    //    {
    //        "HwId": "GTI-Device",
    //        "Data": [
    //        {
    //            "CorrelationId": "DefaultCorrelationId",
    //            "SourceTimestamp": "2020-03-25 23:36:51",
    //            "Values": [
    //            {
    //                "DisplayName": "MedidorDeNivel",
    //                "Address": "100002",
    //                "Value": "1"
    //            }
    //            ]
    //        }
    //        ]
    //    }
    //    ]
    //}
    public class Content
    {
        public string HwId { get; set; }
        public List<Data> Data { get; set; }

    }
}