import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>rssi-1 (dbm)</th>
            <th>rssi-2 (dbm)</th>
            <th>rssi-3 (dbm)</th>
            <th>rssi-4 (dbm)</th>
            <th>Mac ID (dbm)</th>
            <th>Location</th>
            <th>Name</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
                  <td>{forecast.rssi1}</td>
                  <td>{forecast.rssi2}</td>
                  <td>{forecast.rssi3}</td>
                  <td>{forecast.rssi4}</td>
                  <td>{forecast.mac}</td>
              <td>{forecast.location}</td>
                  <td>{forecast.name}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tabelLabel" >Beacon Table</h1>
        <p>This component demonstrates fetching data from the gateway.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('weatherforecast');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
