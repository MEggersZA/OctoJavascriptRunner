module.exports = {
    run: function (cb) {

        console.log(process.env.NODE_ENV);
        cb(null, 'Hello from runner');
    }
}