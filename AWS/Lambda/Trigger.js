exports.handler = function(event, context, callback) {
   console.log("Incoming log Event: ", event);
   const bucket = event.Records[0].s3.bucket.name;
   const filename = decodeURIComponent(event.Records[0].s3.object.key.replace(/\+/g, ' '));
   const message = `The file was uploaded in - ${bucket} -> ${filename}`;
   console.log(message);
   callback(null, message);
};