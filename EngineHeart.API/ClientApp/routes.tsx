import * as React from 'react';
import { Route } from 'react-router-dom';
import { Application } from './components/Application';
import { Home } from './components/Home';
import {Robots} from "./components/Robots";
import {Robot} from "./components/Robot";

export const routes = <Application>
    <Route exact path='/' component={ Home } />
    <Route exact path='/robots' component={ Robots } />
    <Route exact path='/robot/:id' component={ Robot } />
</Application>;
