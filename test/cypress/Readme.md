# Cypress e2e testing suite

Attempt to write some e2e tests for Orchard.

Run `npm install` followed by `npm run test` to build and host Orchard and run cypress test on it.

Look at the `package.json` scripts to see how you can use these scripts to host a site.

To see cypress in action, run these in two different consoles

```
npm run clean // deletes App_Data
npm run host // starts the app on port 5001
```

```
npm run cypress:open // Opens the cypress ui
```

Then, click on run all specs to see it in action.

Tests will fail if not run from a clean install.


## Test data generator

To generate test data, run the following in a console

```
node -e 'require(\"./test_generator\").generateBlogData()'
```
