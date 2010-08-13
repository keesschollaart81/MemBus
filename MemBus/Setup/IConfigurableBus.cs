﻿using System;
using MemBus.Subscribing;

namespace MemBus
{
    public interface IConfigurableBus
    {
        void InsertResolver(ISubscriptionResolver resolver);
        void ConfigurePublishing(Action<IConfigurablePublishing> configure);
        void ConfigureSubscribing(Action<IConfigurableSubscribing> configure);
        void AddSubscription(ISubscription subscription);
        void AddAutomaton(object automaton);
        void AddService<T>(T service);
    }

    public interface IConfigurableSubscribing
    {
      void MessageMatch(Func<MessageInfo, bool> match, Action<IConfigureSubscription> configure);
    }

  public interface IConfigureSubscription
  {
    void ShapeOutwards(params ISubscriptionShaper[] shapers);
  }
}