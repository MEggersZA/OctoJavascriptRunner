

module.exports = function (data, callback) {
    process.env.NODE_ENV = 'production';
    var runner = require(data);
    runner.run(callback);    
};