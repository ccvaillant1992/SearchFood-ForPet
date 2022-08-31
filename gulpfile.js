/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');

gulp.task('default', function () {
    console.log('Welcome to gulp js in Visual Studio');
});

gulp.task('restore', function () {
    return run('build success').exec();
});

gulp.task('build', function () {
    return run('build success').exec();
});

gulp.task('test', function ()  {
    return run('test success').exec();
});
