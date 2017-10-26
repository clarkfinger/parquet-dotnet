/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System.Text;
using Thrift.Protocol;

namespace Parquet.Thrift
{

   /// <summary>
   /// Wrapper struct to specify sort order
   /// </summary>
   class SortingColumn : TBase
  {

    /// <summary>
    /// The column index (in this row group) *
    /// </summary>
    public int Column_idx { get; set; }

    /// <summary>
    /// If true, indicates this column is sorted in descending order. *
    /// </summary>
    public bool Descending { get; set; }

    /// <summary>
    /// If true, nulls will come before non-null values, otherwise,
    /// nulls go at the end.
    /// </summary>
    public bool Nulls_first { get; set; }

    public SortingColumn() {
    }

    public SortingColumn(int column_idx, bool descending, bool nulls_first) : this() {
      this.Column_idx = column_idx;
      this.Descending = descending;
      this.Nulls_first = nulls_first;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_column_idx = false;
        bool isset_descending = false;
        bool isset_nulls_first = false;
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32) {
                Column_idx = iprot.ReadI32();
                isset_column_idx = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                Descending = iprot.ReadBool();
                isset_descending = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                Nulls_first = iprot.ReadBool();
                isset_nulls_first = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
        if (!isset_column_idx)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_descending)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_nulls_first)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SortingColumn");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "column_idx";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Column_idx);
        oprot.WriteFieldEnd();
        field.Name = "descending";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Descending);
        oprot.WriteFieldEnd();
        field.Name = "nulls_first";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Nulls_first);
        oprot.WriteFieldEnd();
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SortingColumn(");
      __sb.Append(", Column_idx: ");
      __sb.Append(Column_idx);
      __sb.Append(", Descending: ");
      __sb.Append(Descending);
      __sb.Append(", Nulls_first: ");
      __sb.Append(Nulls_first);
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
