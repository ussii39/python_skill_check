process.stdin.resume();
process.stdin.setEncoding("utf8");
// 自分の得意な言語で
// Let's チャレンジ！！
var lines = [];
var reader = require("readline").createInterface({
  input: process.stdin,
  output: process.stdout,
});
reader.on("line", (line) => {
  // D
  // w_0 w_1 ... w_{D-1}
  // 天気予報では0が晴れ、 1 がくもり、 2 が雨を表します。
  // 今日を含めた D 日間の天気予報が与えられます。
  // 虹が見られる可能性がある日を 1 日目から順にすべて出力してください。
  // そのような日がない場合は -1 を出力してください。
  lines.push(line);
});
reader.on("close", () => {
  D = Number(lines[0]);
  //   console.log(D);
  const weathers = lines[1]
    .trim()
    .split(" ")
    .map((x) => Number(x));
  //   console.log(weathers)
  let prev_weather = weathers[0];
  const rainbow_days = [];
  for (i = 1; i <= D - 1; i++) {
    //   console.log(prev_weather,weathers[i])
    if (prev_weather === 2 && weathers[i] === 0) {
      rainbow_days.push(i);
    }
    prev_weather = weathers[i];
  }
  const result = rainbow_days.length > 0 ? rainbow_days.join(" ") : -1;

  console.log(result);
  //   console.log(prev_weather)
});
