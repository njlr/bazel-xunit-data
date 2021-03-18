load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "fsharp_xunit_test")

fsharp_xunit_test(
  name = "bazel_xunit_test_data.dll",
  srcs = [
    "Tests.fs",
  ],
  data = glob([
    "test-data/*.txt",
  ]),
  deps = [
    "@core_sdk_stdlib//:libraryset",
    "@fsharp.core//:lib",
    "@fsunit.xunit//:lib",
  ],
)
