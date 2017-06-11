# Octopus Deploy Javascript Runner

OctoJavascriptRunner provides an easy way to run javascript/node code using Octopus Deploy

## Why?

In deploying node apps to Microsoft Azure from OctopusDeploy I needed a way to run knex migrations from a windows box

## How?

The powershell Deploy.ps1 script OctopusDeploy invokes, calls a .net exe which uses the fantastic EdgeJS (http://tjanczuk.github.io/edge/) to run javascript code.

Simple change the runner.js script to be any javascript code you like...
Something like

```javascript
module.exports = {
    run: function (cb) {

        var knex = require('./db.js');

        knex.migrate.latest()
        .then(function() {
          cb(null, 'migrations are complete.');
        })
        .then(function() {
           knex.destroy();
        })
        .catch(function(e) {
          cb(e, 'migrations failed...');
        });
    }
}
```

