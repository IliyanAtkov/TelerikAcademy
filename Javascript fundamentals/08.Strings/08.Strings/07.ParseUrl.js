﻿// Write a script that parses an URL address given in
// the format:
//     [protocol]://[server]/[resource]
// and [resource] elements. Return the elements in
// a JSON object.
// For example from the URL
// http://www.devbg.org/forum/index.php the
//     following information should be extracted:
//     ,
//         server: 'www.devbg.org',
//         resource: '/forum/index.php'}