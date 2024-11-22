FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
#COPY --from=build-env /App/out .
COPY ./bin/Release/net8.0/linux-x64/publish .
RUN chmod +x /App/TriDataSyncExternalDb

CMD ["/bin/bash"]

ENTRYPOINT ["/App/TriDataSyncExternalDb"]
