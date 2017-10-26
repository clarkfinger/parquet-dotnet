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
   /// Represents a element inside a schema definition.
   ///  - if it is a group (inner node) then type is undefined and num_children is defined
   ///  - if it is a primitive type (leaf) then type is defined and num_children is undefined
   /// the nodes are listed in depth first traversal order.
   /// </summary>
   class SchemaElement : TBase
  {
    private Type _type;
    private int _type_length;
    private FieldRepetitionType _repetition_type;
    private int _num_children;
    private ConvertedType _converted_type;
    private int _scale;
    private int _precision;
    private int _field_id;

    /// <summary>
    /// Data type for this field. Not set if the current element is a non-leaf node
    /// 
    /// <seealso cref="Type"/>
    /// </summary>
    public Type Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    /// <summary>
    /// If type is FIXED_LEN_BYTE_ARRAY, this is the byte length of the vales.
    /// Otherwise, if specified, this is the maximum bit length to store any of the values.
    /// (e.g. a low cardinality INT col could have this set to 3).  Note that this is
    /// in the schema, and therefore fixed for the entire file.
    /// </summary>
    public int Type_length
    {
      get
      {
        return _type_length;
      }
      set
      {
        __isset.type_length = true;
        this._type_length = value;
      }
    }

    /// <summary>
    /// repetition of the field. The root of the schema does not have a repetition_type.
    /// All other nodes must have one
    /// 
    /// <seealso cref="FieldRepetitionType"/>
    /// </summary>
    public FieldRepetitionType Repetition_type
    {
      get
      {
        return _repetition_type;
      }
      set
      {
        __isset.repetition_type = true;
        this._repetition_type = value;
      }
    }

    /// <summary>
    /// Name of the field in the schema
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Nested fields.  Since thrift does not support nested fields,
    /// the nesting is flattened to a single list by a depth-first traversal.
    /// The children count is used to construct the nested relationship.
    /// This field is not set when the element is a primitive type
    /// </summary>
    public int Num_children
    {
      get
      {
        return _num_children;
      }
      set
      {
        __isset.num_children = true;
        this._num_children = value;
      }
    }

    /// <summary>
    /// When the schema is the result of a conversion from another model
    /// Used to record the original type to help with cross conversion.
    /// 
    /// <seealso cref="ConvertedType"/>
    /// </summary>
    public ConvertedType Converted_type
    {
      get
      {
        return _converted_type;
      }
      set
      {
        __isset.converted_type = true;
        this._converted_type = value;
      }
    }

    /// <summary>
    /// Used when this column contains decimal data.
    /// See the DECIMAL converted type for more details.
    /// </summary>
    public int Scale
    {
      get
      {
        return _scale;
      }
      set
      {
        __isset.scale = true;
        this._scale = value;
      }
    }

    public int Precision
    {
      get
      {
        return _precision;
      }
      set
      {
        __isset.precision = true;
        this._precision = value;
      }
    }

    /// <summary>
    /// When the original schema supports field ids, this will save the
    /// original field id in the parquet schema
    /// </summary>
    public int Field_id
    {
      get
      {
        return _field_id;
      }
      set
      {
        __isset.field_id = true;
        this._field_id = value;
      }
    }


    public Isset __isset;
    
    
    
    public struct Isset {
      public bool type;
      public bool type_length;
      public bool repetition_type;
      public bool num_children;
      public bool converted_type;
      public bool scale;
      public bool precision;
      public bool field_id;
    }

    public SchemaElement() {
    }

    public SchemaElement(string name) : this() {
      this.Name = name;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_name = false;
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
                Type = (Type)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Type_length = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Repetition_type = (FieldRepetitionType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
                isset_name = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I32) {
                Num_children = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I32) {
                Converted_type = (ConvertedType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I32) {
                Scale = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I32) {
                Precision = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.I32) {
                Field_id = iprot.ReadI32();
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
        if (!isset_name)
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
        TStruct struc = new TStruct("SchemaElement");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.type) {
          field.Name = "type";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Type);
          oprot.WriteFieldEnd();
        }
        if (__isset.type_length) {
          field.Name = "type_length";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Type_length);
          oprot.WriteFieldEnd();
        }
        if (__isset.repetition_type) {
          field.Name = "repetition_type";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Repetition_type);
          oprot.WriteFieldEnd();
        }
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
        if (__isset.num_children) {
          field.Name = "num_children";
          field.Type = TType.I32;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Num_children);
          oprot.WriteFieldEnd();
        }
        if (__isset.converted_type) {
          field.Name = "converted_type";
          field.Type = TType.I32;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Converted_type);
          oprot.WriteFieldEnd();
        }
        if (__isset.scale) {
          field.Name = "scale";
          field.Type = TType.I32;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Scale);
          oprot.WriteFieldEnd();
        }
        if (__isset.precision) {
          field.Name = "precision";
          field.Type = TType.I32;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Precision);
          oprot.WriteFieldEnd();
        }
        if (__isset.field_id) {
          field.Name = "field_id";
          field.Type = TType.I32;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Field_id);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SchemaElement(");
      bool __first = true;
      if (__isset.type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (__isset.type_length) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type_length: ");
        __sb.Append(Type_length);
      }
      if (__isset.repetition_type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Repetition_type: ");
        __sb.Append(Repetition_type);
      }
      if(!__first) { __sb.Append(", "); }
      __sb.Append("Name: ");
      __sb.Append(Name);
      if (__isset.num_children) {
        __sb.Append(", Num_children: ");
        __sb.Append(Num_children);
      }
      if (__isset.converted_type) {
        __sb.Append(", Converted_type: ");
        __sb.Append(Converted_type);
      }
      if (__isset.scale) {
        __sb.Append(", Scale: ");
        __sb.Append(Scale);
      }
      if (__isset.precision) {
        __sb.Append(", Precision: ");
        __sb.Append(Precision);
      }
      if (__isset.field_id) {
        __sb.Append(", Field_id: ");
        __sb.Append(Field_id);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
