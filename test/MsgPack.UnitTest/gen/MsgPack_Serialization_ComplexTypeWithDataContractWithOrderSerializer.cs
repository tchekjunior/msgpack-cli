﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeWithDataContractWithOrderSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer0;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> this_PackValueOfSourceDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> this_PackValueOfDataDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer2;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> this_PackValueOfTimeStampDelegate;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer3;
        
        private System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> this_PackValueOfHistoryDelegate;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>> _packOperationTable;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfSourceAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfDataAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfTimeStampAsyncDelegate;
        
        private System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_PackValueOfHistoryAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Uri> this_SetUnpackedValueOfSourceDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int> this_UnpackValueOfSourceDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, byte[]> this_SetUnpackedValueOfDataDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, byte[]> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int> this_UnpackValueOfDataDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.DateTime> this_SetUnpackedValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int> this_UnpackValueOfTimeStampDelegate;
        
        private System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Collections.Generic.Dictionary<System.DateTime, string>> this_SetUnpackedValueOfHistoryDelegate;
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int> this_UnpackValueOfHistoryDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfSourceAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>> MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfDataAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfTimeStampAsyncDelegate;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> this_UnpackValueOfHistoryAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_ComplexTypeWithDataContractWithOrderSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Uri>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            this._serializer2 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer3 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema2);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>[4];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfSource);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfData);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfTimeStamp);
            packOperationList[3] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfHistory);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>[4];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationListAsync[1] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationListAsync[2] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            packOperationListAsync[3] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>>(4);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfSource);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfData);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfTimeStamp);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfHistory);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(4);
            packOperationTableAsync["Source"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            packOperationTableAsync["Data"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            packOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            packOperationTableAsync["History"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfSource);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfData);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfHistory);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[4];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationListAsync[1] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationListAsync[2] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            unpackOperationListAsync[3] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>>(4);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfSource);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfData);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfTimeStamp);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfHistory);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(4);
            unpackOperationTableAsync["Source"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            unpackOperationTableAsync["Data"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            unpackOperationTableAsync["TimeStamp"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            unpackOperationTableAsync["History"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Source",
                    "Data",
                    "TimeStamp",
                    "History"};
            this.this_PackValueOfSourceDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfSource);
            this.this_PackValueOfDataDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfData);
            this.this_PackValueOfTimeStampDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfTimeStamp);
            this.this_PackValueOfHistoryDelegate = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfHistory);
            this.this_PackValueOfSourceAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfSourceAsync);
            this.this_PackValueOfDataAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDataAsync);
            this.this_PackValueOfTimeStampAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTimeStampAsync);
            this.this_PackValueOfHistoryAsyncDelegate = new System.Func<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfHistoryAsync);
            this.this_SetUnpackedValueOfSourceDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Uri>(this.SetUnpackedValueOfSource);
            this.this_UnpackValueOfSourceDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfSource);
            this.this_SetUnpackedValueOfDataDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, byte[]>(this.SetUnpackedValueOfData);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, byte[]>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue);
            this.this_UnpackValueOfDataDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfData);
            this.this_SetUnpackedValueOfTimeStampDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.DateTime>(this.SetUnpackedValueOfTimeStamp);
            this.this_UnpackValueOfTimeStampDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfTimeStamp);
            this.this_SetUnpackedValueOfHistoryDelegate = new System.Action<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, System.Collections.Generic.Dictionary<System.DateTime, string>>(this.SetUnpackedValueOfHistory);
            this.this_UnpackValueOfHistoryDelegate = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int>(this.UnpackValueOfHistory);
            this.this_UnpackValueOfSourceAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfSourceAsync);
            this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<byte[]>>(MsgPack.Serialization.UnpackHelpers.UnpackBinaryValueAsync);
            this.this_UnpackValueOfDataAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDataAsync);
            this.this_UnpackValueOfTimeStampAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTimeStampAsync);
            this.this_UnpackValueOfHistoryAsyncDelegate = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfHistoryAsync);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer0.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer1.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer2.PackTo(packer, objectTree.TimeStamp);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer3.PackTo(packer, objectTree.History);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfSourceAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Source, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfDataAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer1.PackToAsync(packer, objectTree.Data, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfTimeStampAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer2.PackToAsync(packer, objectTree.TimeStamp, cancellationToken);
        }
        
        private System.Threading.Tasks.Task PackValueOfHistoryAsync(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer3.PackToAsync(packer, objectTree.History, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree, System.Threading.CancellationToken cancellationToken) {
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(packer, objectTree, this._packOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(packer, objectTree, this._packOperationTableAsync, cancellationToken);
            }
        }
        
        private void SetUnpackedValueOfSource(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, System.Uri unpackedValue) {
            unpackingContext.Source = unpackedValue;
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceDelegate);
        }
        
        private void SetUnpackedValueOfData(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, byte[] unpackedValue) {
            unpackingContext.Data = unpackedValue;
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueDelegate, this.this_SetUnpackedValueOfDataDelegate);
        }
        
        private void SetUnpackedValueOfTimeStamp(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, System.DateTime unpackedValue) {
            unpackingContext.TimeStamp = unpackedValue;
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampDelegate);
        }
        
        private void SetUnpackedValueOfHistory(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, System.Collections.Generic.Dictionary<System.DateTime, string> unpackedValue) {
            System.Collections.Generic.Dictionary<System.DateTime, string> existent = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            existent = unpackingContext.History;
            System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistoryDelegate);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithDataContractWithOrder UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithDataContractWithOrder result = default(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder);
            result = new MsgPack.Serialization.ComplexTypeWithDataContractWithOrder();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfSourceAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer0, itemsCount, indexOfItem, typeof(System.Uri), "Source", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfSourceDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDataAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer1, itemsCount, indexOfItem, typeof(byte[]), "Data", MsgPack.Serialization.NilImplication.MemberDefault, this.MsgPack_Serialization_UnpackHelpers_UnpackBinaryValueAsyncDelegate, this.this_SetUnpackedValueOfDataDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTimeStampAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(unpacker, unpackingContext, this._serializer2, itemsCount, indexOfItem, typeof(System.DateTime), "TimeStamp", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfTimeStampDelegate, cancellationToken);
        }
        
        private System.Threading.Tasks.Task UnpackValueOfHistoryAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(unpacker, unpackingContext, this._serializer3, itemsCount, indexOfItem, typeof(System.Collections.Generic.Dictionary<System.DateTime, string>), "History", MsgPack.Serialization.NilImplication.MemberDefault, null, this.this_SetUnpackedValueOfHistoryDelegate, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.ComplexTypeWithDataContractWithOrder result = default(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder);
            result = new MsgPack.Serialization.ComplexTypeWithDataContractWithOrder();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}