/**
 * @fileoverview
 * @enhanceable
 * @suppress {messageConventions} JS Compiler reports an error if a variable or
 *     field starts with 'MSG_' and isn't a translatable message.
 * @public
 */
// GENERATED CODE -- DO NOT EDIT!

goog.provide('proto.com.obsessiveorange.opxform.Patch');

goog.require('jspb.BinaryReader');
goog.require('jspb.BinaryWriter');
goog.require('jspb.Message');
goog.require('proto.com.obsessiveorange.opxform.Diff');


/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.com.obsessiveorange.opxform.Patch = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, proto.com.obsessiveorange.opxform.Patch.repeatedFields_, null);
};
goog.inherits(proto.com.obsessiveorange.opxform.Patch, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  proto.com.obsessiveorange.opxform.Patch.displayName = 'proto.com.obsessiveorange.opxform.Patch';
}
/**
 * List of repeated fields within this message type.
 * @private {!Array<number>}
 * @const
 */
proto.com.obsessiveorange.opxform.Patch.repeatedFields_ = [3];



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.toObject = function(opt_includeInstance) {
  return proto.com.obsessiveorange.opxform.Patch.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.com.obsessiveorange.opxform.Patch} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.com.obsessiveorange.opxform.Patch.toObject = function(includeInstance, msg) {
  var f, obj = {
    baseversion: jspb.Message.getFieldWithDefault(msg, 1, 0),
    basedoclength: jspb.Message.getFieldWithDefault(msg, 2, 0),
    diffsList: jspb.Message.toObjectList(msg.getDiffsList(),
    proto.com.obsessiveorange.opxform.Diff.toObject, includeInstance)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.com.obsessiveorange.opxform.Patch}
 */
proto.com.obsessiveorange.opxform.Patch.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.com.obsessiveorange.opxform.Patch;
  return proto.com.obsessiveorange.opxform.Patch.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.com.obsessiveorange.opxform.Patch} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.com.obsessiveorange.opxform.Patch}
 */
proto.com.obsessiveorange.opxform.Patch.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = /** @type {number} */ (reader.readInt64());
      msg.setBaseversion(value);
      break;
    case 2:
      var value = /** @type {number} */ (reader.readInt64());
      msg.setBasedoclength(value);
      break;
    case 3:
      var value = new proto.com.obsessiveorange.opxform.Diff;
      reader.readMessage(value,proto.com.obsessiveorange.opxform.Diff.deserializeBinaryFromReader);
      msg.addDiffs(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.com.obsessiveorange.opxform.Patch.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.com.obsessiveorange.opxform.Patch} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.com.obsessiveorange.opxform.Patch.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getBaseversion();
  if (f !== 0) {
    writer.writeInt64(
      1,
      f
    );
  }
  f = message.getBasedoclength();
  if (f !== 0) {
    writer.writeInt64(
      2,
      f
    );
  }
  f = message.getDiffsList();
  if (f.length > 0) {
    writer.writeRepeatedMessage(
      3,
      f,
      proto.com.obsessiveorange.opxform.Diff.serializeBinaryToWriter
    );
  }
};


/**
 * optional int64 baseVersion = 1;
 * @return {number}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.getBaseversion = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 1, 0));
};


/** @param {number} value */
proto.com.obsessiveorange.opxform.Patch.prototype.setBaseversion = function(value) {
  jspb.Message.setField(this, 1, value);
};


/**
 * optional int64 baseDocLength = 2;
 * @return {number}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.getBasedoclength = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 2, 0));
};


/** @param {number} value */
proto.com.obsessiveorange.opxform.Patch.prototype.setBasedoclength = function(value) {
  jspb.Message.setField(this, 2, value);
};


/**
 * repeated Diff diffs = 3;
 * @return {!Array.<!proto.com.obsessiveorange.opxform.Diff>}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.getDiffsList = function() {
  return /** @type{!Array.<!proto.com.obsessiveorange.opxform.Diff>} */ (
    jspb.Message.getRepeatedWrapperField(this, proto.com.obsessiveorange.opxform.Diff, 3));
};


/** @param {!Array.<!proto.com.obsessiveorange.opxform.Diff>} value */
proto.com.obsessiveorange.opxform.Patch.prototype.setDiffsList = function(value) {
  jspb.Message.setRepeatedWrapperField(this, 3, value);
};


/**
 * @param {!proto.com.obsessiveorange.opxform.Diff=} opt_value
 * @param {number=} opt_index
 * @return {!proto.com.obsessiveorange.opxform.Diff}
 */
proto.com.obsessiveorange.opxform.Patch.prototype.addDiffs = function(opt_value, opt_index) {
  return jspb.Message.addToRepeatedWrapperField(this, 3, opt_value, proto.com.obsessiveorange.opxform.Diff, opt_index);
};


proto.com.obsessiveorange.opxform.Patch.prototype.clearDiffsList = function() {
  this.setDiffsList([]);
};

